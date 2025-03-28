import React, { useState } from "react";

const Voting = () =>{

    const[age,setAge] = useState(25);

    // if(age>18)
    // {
    //     return(
    //         <div>"You can vote"</div>
    //     );
       
    // }
    return(
       <div>
        {
            (age>=18) ? "You Can Vote" :"You Cannot Vote"
        }
       </div>
    )
}


export default Voting