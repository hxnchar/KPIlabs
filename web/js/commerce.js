let D = new Date(Date.now());
D.setDate(D.getDate() + 14)

let span = document.querySelector("#date");
if(D.getMonth().toString().length==1){
    span.innerText = D.getDate() + ".0" + (D.getMonth()+1)
}else{
    span.innerText = D.getDate() + "." + (D.getMonth()+1)
}