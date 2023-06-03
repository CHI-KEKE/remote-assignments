//     *** Request 1: Click to Change Text. *** 


//JS

// const headingBlock = document.querySelector('.heading');

// headingBlock.addEventListener('click', () => {
//   const headingText = document.querySelector('.heading-text');
//   headingText.textContent = headingText.textContent === 'Welcome To Doggy SPA!'? 'Have a Good Time!':'Welcome To Doggy SPA!';
// });

//jQuery
$('.heading').on('click',() => {
  const changeToText = $('.heading-text').text() === 'Welcome To Doggy SPA!'? 'Have a Good Time!':'Welcome To Doggy SPA!';
  $('.heading-text').text(changeToText);
})





//     *** Request 2: Click to Show More Content Boxes ***


//JS

// const showMoreButton = document.querySelector(".btn");
// const content_2 = document.querySelector('.content-2');


// showMoreButton.addEventListener("click",() => {
//   content_2.classList.toggle("hidden");
// })


//jQuery

$('.btn').on('click', () => {
  $('.content-2').toggleClass('hidden');
});