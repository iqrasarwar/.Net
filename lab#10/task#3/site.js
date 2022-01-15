// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let num1 = document.getElementById("num1");
let num2 = document.getElementById("num2");
let op = document.getElementById("op");
let res = document.getElementById("res");

let operations = ['add','sub','mul','div'];

let rand1 = Math.floor(Math.random() * 100);
let rand2 = Math.floor(Math.random() * 100);
let rand3 = Math.floor(Math.random() * 100) % 4;

num1.innerHTML = rand1;
num2.innerHTML = rand2;
if(rand3 == 0)
{
   op.innerHTML = "+";
   res.innerHTML = parseInt(rand1)+parseInt(rand2);
}
else if(rand3 == 1)
{
   op.innerHTML = "-";
   res.innerHTML = parseInt(rand1)-parseInt(rand2);
}
else if(rand3 == 2)
{
   op.innerHTML = "*";
   res.innerHTML = parseInt(rand1)*parseInt(rand2);
}
else if(rand3 == 3)
{
   op.innerHTML = "/";
   res.innerHTML = parseInt(rand1)/parseInt(rand2);
}
