document.addEventListener('DOMContentLoaded', function () {
    var littleBox = document.getElementById('little-box');
    var menuBar = document.getElementById('menu-bar');

    littleBox.addEventListener('click', function () {
        menuBar.classList.toggle('active');
        console.log('Menu bar is active:', menuBar.classList.contains('active'));
    });

});


window.stopPropagation = function (event) {
    event.stopPropagation();
};

window.preventDefault = function (event) {
    event.preventDefault();
};