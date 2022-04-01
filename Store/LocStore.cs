using Blazored.LocalStorage;
using Fluxor;
using System;
using System.Threading.Tasks;

namespace MiniProject.Store
{
  public record LocState
  {
    public int CurrentLoc { get; init; }
    public int LocClick { get; init; }
    public int LocSec { get; init; }
  }

  public class LocFeature : Feature<LocState>
  {
    public override string GetName() => "Lines of Code";

    protected override LocState GetInitialState()
    {
      return new LocState
      {
        CurrentLoc = 0,
        LocClick = 1,
        LocSec = 1
      };
    }
  }

  public static class LocReducers
  {
    [ReducerMethod(typeof(LocIncrementAction))]
    public static LocState OnIncrement(LocState state)
    {
      return state with
      {
        CurrentLoc = state.CurrentLoc + state.LocClick
      };
    }

    [ReducerMethod(typeof(LocLoopAction))]
    public static LocState OnLoop(LocState state)
    {
      return state with
      {
        CurrentLoc = state.CurrentLoc + state.LocSec
      };
    }

    [ReducerMethod]
    public static LocState OnLocSetState(LocState state, LocSetStateAction action)
    {
      return action.LocState;
    }
  }

  public class LocEffects
  {
    private readonly ILocalStorageService _localStorageService;
    private const string LocStatePersistenceName = "MiniProject_LocState";

    public LocEffects(ILocalStorageService localStorageService)
    {
      _localStorageService = localStorageService;
    }

    [EffectMethod]
    public async Task GameLoop(LocLoopAction action, IDispatcher dispatcher)
    {
      await Task.Delay(1000);
      dispatcher.Dispatch(new LocLoopAction());
    }

    [EffectMethod]
    public async Task PersistState(LocPersistStateAction action, IDispatcher dispatcher)
    {
      try
      {
        await _localStorageService.SetItemAsync(LocStatePersistenceName, action.LocState);
        dispatcher.Dispatch(new LocPersistStateSuccessAction());
      }
      catch (Exception ex)
      {
        dispatcher.Dispatch(new LocPersistStateFailureAction(ex.Message));
      }
    }

    [EffectMethod(typeof(LocLoadStateAction))]
    public async Task LoadState(IDispatcher dispatcher)
    {
      try
      {
        var LocState = await _localStorageService.GetItemAsync<LocState>(LocStatePersistenceName);
        if (LocState is not null)
        {
          dispatcher.Dispatch(new LocSetStateAction(LocState));
          dispatcher.Dispatch(new LocLoadStateSuccessAction());
        }
      }
      catch (Exception ex)
      {
        dispatcher.Dispatch(new LocLoadStateFailureAction(ex.Message));
      }
    }

    [EffectMethod(typeof(LocClearStateAction))]
    public async Task ClearState(IDispatcher dispatcher)
    {
      try
      {
        await _localStorageService.RemoveItemAsync(LocStatePersistenceName);
        dispatcher.Dispatch(new LocSetStateAction(new LocState { CurrentLoc = 0 }));
        dispatcher.Dispatch(new LocClearStateSuccessAction());
      }
      catch (Exception ex)
      {
        dispatcher.Dispatch(new LocClearStateFailureAction(ex.Message));
      }
    }
  }

  #region LocActions
  public record LocIncrementAction();
  public record LocIncrementSecAction();
  public record LocSetStateAction(LocState LocState);
  public record LocLoopAction();
  public record LocPersistStateAction(LocState LocState);
  public record LocPersistStateSuccessAction();
  public record LocPersistStateFailureAction(string ErrorMessage);
  public record LocLoadStateAction();
  public record LocLoadStateSuccessAction();
  public record LocLoadStateFailureAction(string ErrorMessage);
  public record LocClearStateAction();
  public record LocClearStateSuccessAction();
  public record LocClearStateFailureAction(string ErrorMessage);
  #endregion
}