var num=2853;
let a=(num-num%1000)/1000;
let b=((num%1000)-(num%100))/100;
let c=(((num%1000)%100)-((num%1000)%100)%10)/10;
let d=num%10;
let result=(d*1000)+(c*100)+(b*10)+(a*1);
console.log(result);