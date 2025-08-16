// console.log("Welcome to Typescript");
// var company = "Wipro";
// var para = document.createElement("h1");
// para.textContent = company;
// document.body.appendChild(para);
import Companies from "./Data.js"; 

console.log("Welcome to Typescript");
// var company = "Wipro";
Companies.forEach( (company)=>{
     var para = document.createElement("h1");
para.textContent=company;
document.body.appendChild(para);
}) 
   
// var para = document.createElement("h1");
// para.textContent=company;
// document.body.appendChild(para);
