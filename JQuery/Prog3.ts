import Companies from "./Data.js";
let company : string = "Wipro"
let topic : string = "TypeScript Programming"
let batch : string = "Dotnet FSD"
let data : any = "Hello World"

Companies.forEach((company) => {
    console.log(company,topic, batch,data)

});
