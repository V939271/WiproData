import Companies from "./Data"; 

console.log("Welcome to Typescript");
// var company = "Wipro";
foreach(var company in Companies) {
    var para = document.createElement("h1");
para.textContent=company;
document.body.appendChild(para);
};
// var para = document.createElement("h1");
// para.textContent=company;
// document.body.appendChild(para);