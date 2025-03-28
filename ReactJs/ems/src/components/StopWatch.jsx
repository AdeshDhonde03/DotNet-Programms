import React, { useEffect,useRef, useState } from 'react'

const StopWatch = () => {
    const[seconds,setSeconds]=useState(0);

    let intervalRef = useRef();

    function handleStart(){
        intervalRef.current = setInterval(()=>{
            setSeconds((previousSeconds)=>{
                return previousSeconds +1;
            });

        },1000);
    }

    function handleStop(){
        clearInterval(intervalRef.current);

    }

    function handleReset(){
        setSeconds(0);
    }
  return (
    <div>
      <div>{seconds}</div>
            <button onClick={handleStart}>start</button>
            <button onClick={handleStop}>stop</button>
            <button onClick={handleReset}>reset</button>
    </div>
  )
}

export default StopWatch
