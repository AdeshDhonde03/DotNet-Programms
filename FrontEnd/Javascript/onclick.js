let handleInput=()=>
    {
        let height=document.getElementById("height");
        let weight=document.getElementById("Weight");
        let errorpara=document.getElementById("errorMessage");
        let bmi=weight.value/(height.value*height.value);
        // let bmiValue=document.getElementsByName("bmi");
        console.log(bmi);
        if(bmi<=18.5)
        {
            errorpara.innerHTML="You are underweight";
            errorpara.style.color="green";
        }else if(bmi>18.5 && bmi<=24.9)
        {
            errorpara.innerHTML="Normal";
            errorpara.style.color="aqua";
        }
        else if(bmi>=25 && bmi<=50)
            {
                errorpara.innerHTML="Normal weight";
                errorpara.style.color="grey";
            }
            else if(bmi>=50.5 && bmi<=75)
                {
                    errorpara.innerHTML="Normal weight Increased";
                    errorpara.style.color="blue";
                }
                else if(bmi>=75.5 && bmi<=100)
                    {
                        errorpara.innerHTML="You are Overweight";
                        errorpara.style.color="orange";
                    }
        else{
            errorpara.innerHTML=" you enter Invalid Age and weight";
            errorpara.style.color="red";
        }
    
        
    
    
    
    }