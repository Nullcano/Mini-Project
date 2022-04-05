const cat = document.querySelector('.cat');

const randomWords = ['abstract', 'array', 'bool', 'break', 'catch', 'class', 'console', 'continue', 'do', 'double', 'else-if', 'else', 'enum', 'finally', 'for', 'foreach', 'get', 'if', 'int', 'interface', 'internal', 'list', 'math', 'namespace', 'override', 'private', 'protected', 'public', 'set', 'static', 'string', 'switch', 'try', 'using', 'while'];

const randomWord = () => { return randomWords[Math.floor(Math.random() * randomWords.length)] }
const randomInteger = (min, max) => Math.floor(Math.random() * (max - min + 1)) + min;

cat.addEventListener('click', function() {
  const word = document.createElement('div');
  const syntaxContainer = document.querySelector('.syntax-container');
  word.classList.add('word');
  word.style.backgroundImage = `url(assets/syntax/${randomWord()}.gif)`;
  word.style.left = `${randomInteger(-5, 80)}%`;
  syntaxContainer.appendChild(word);

  let start, previousTimeStamp;
  let done = false

  const step = (timestamp) => {

    if (start === undefined) {
      start = timestamp;
    }
    const elapsed = timestamp - start;

    if (previousTimeStamp !== timestamp) {
      let opacity = (elapsed / 1000) / 2;
      const count = Math.min(0.1 * elapsed, 1000);
      word.style.transform = 'translateY(-' + count + 'px)';
      word.style.opacity = opacity;
      if (count === 1000) {
        done = true;
      }
    }

    if (elapsed < 2000) {
      previousTimeStamp = timestamp
      !done && window.requestAnimationFrame(step);
    }
  }
  setTimeout(() => {
    syntaxContainer.removeChild(word);
  }, 2000);
  window.requestAnimationFrame(step);
});