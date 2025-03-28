import React,{ useEffect, useRef, useState } from 'react'

const Counter = () => {
    const[count,setCount]=useState(0);
      const num=useRef(0);

      const elementRef = useRef();
      useEffect(()=>{
        if(num.current%2==0)
        {
            elementRef.current.style.backgroundColor = "Green";
        }else{
            elementRef.current.style.backgroundColor = "Red";
        }

    })

  return (
    <>
    <div>{count}</div>
    <div ref={elementRef}>{num.current}</div>
    <button onClick={()=>{
        setCount(count + 1);                 
        num.current = num.current + 1;
    }}>Increment by 1</button>
    </>
    )
}

export default Counter
