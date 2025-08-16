interface IEmploy {
    empno : number;
    name : string;
    salary : number;
}

const employ1 : IEmploy = {
    empno:1,
    name:"Prasanna",
    salary:88234
}

console.log(`Employ No ${employ1.empno} Employ Name ${employ1.name} Salary ${employ1.salary}  `)