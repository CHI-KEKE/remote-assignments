const headingBlock = document.querySelector('.heading');
const showMoreButton = document.querySelector(".btn");
const content_2 = document.querySelector('.content-2');

headingBlock.addEventListener('click', () => {
  const headingText = document.querySelector('.heading-text');
  headingText.textContent = 'Have a Good Time!';
});

showMoreButton.addEventListener("click",() => {
    content_2.classList.toggle("hidden");
})
