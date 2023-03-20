var num=2332;
let a=((num%1000)%100)%10;
let b=(num%1000)/100-((num%1000)%100)/100;
let c=((num%1000)%100)/10-(((num%1000)%100)%10)/10;
let d=(num%10);
 if(a==d && b==c){
    console.log(true);
 }
 else{
    console.log(false);
 }