import React, { useEffect, useState } from 'react'
const Counter =() =>
{
    const[count,setCount] = useState(0);
    const[secondCount,setSeconCount] = useState(0);

    useEffect(() =>{
        console.log("The value of count is" +count);
    })

    return(
        <div>
            <p>{count}</p>
            <button onClick={()=>{
                setCount(count+1);
             }}>Increase count by 1</button>
        </div>
    )
}



export default Counter