function calculate()
{
    let str = document.getElementById("input").value;
        
    let equalsSign = str.match(/\=/g);

    if(equalsSign && equalsSign.length == 1 && str.indexOf("=") == str.length - 1){

        let numbers = str.match(/\d+\.?\d*/g);
        let symbols = str.match(/\+|\-|\*|\//g);
        let res = +numbers[0];
        
        for(let i=0; i<symbols.length;i++){
            switch(symbols[i]){
                case '+': res += +numbers[i+1];
                break;
                case '-': res -= numbers[i+1];
                break; 
                case '*': res *= numbers[i+1];
                break; 
                case '/': res /= numbers[i+1];
                break;
            }
        }

        res = Math.ceil((res)*100)/100;
        document.getElementById("output").value = res;
    }else{
        document.getElementById("output").value = "error";
    }
}
