
const toggleButton = document.querySelector('[data-option="toggle"]');
console.log(toggleButton)

const menu = document.querySelector(toggleButton.dataset.target);
console.log(menu)


toggleButton.addEventListener('click', function () {
    menu.classList.toggle('show'); 
});