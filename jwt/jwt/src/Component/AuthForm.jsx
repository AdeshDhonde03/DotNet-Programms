import React, { useState } from 'react'
import { useAuth } from './AuthContext';
import { useNavigate } from 'react-router-dom';

const AuthForm = () => {

    const[isLogIn,SetLogIn]=useState(true);
    
    const[createUser,SetUser]=useState({
        "Name":"",
        "UserName":"",
        "Password":""
    });

    const {login} = useAuth();
    const[logInData,SetLogInData]=useState({
        "UserName":"",
        "Password":""
    });
    const navigate =useNavigate();


    //SignUp
    async function addUser(e) {
        e.preventDefault();
        let options ={
            "method":"POST",
            "headers":{
                "Content-Type":"application/json"
            },
            "body":JSON.stringify(createUser)
        }
        let response = await fetch(`https://localhost:7217/api/Auth/addUser`,options);
        console.log(response);
        
        SetUser({
            "Name":"",
            "UserName":"",
            "Password":""
        });
        
    }

    function handleChange(e)
    {
     SetUser({...createUser,[e.target.name]:e.target.value});   
    }

    //LogIn
    async function logIn1(e)
    {
        e.preventDefault();
        
       try{
        console.log("Login button clicked");
        let options = {
            "method":"POST",
            "headers":{
                 "Content-Type":"application/json"
            },
            "body":JSON.stringify(logInData)
           
        };
        let response = await fetch(`https://localhost:7217/api/Auth/logIn`,options);
        if(response.ok){
            console.log(response);
            let token = await response.text();
            console.log("Login successful. Token:", token);
            login(token)
            navigate("/dashboard");
            console.log("Token stored in context. Navigating to /dashboard");

        }else {
            alert("Invalid username or password");
        }
       }catch(error)
       {
        console.error("LogIn Failed",error);
       }
       
    
    }

    function handleLogIn(e)
    {
        SetLogInData({...logInData,[e.target.name]:e.target.value});
    }

    return (
     <div className='container'>
       
        <div className='form-container'>
        <h3><b>AdiaSquare Pvt.ltd Company</b></h3>
            <div className='form-toggle'>
                <button className={isLogIn ? 'active' : ""} onClick={() => SetLogIn(true)}>LogIn</button>
                <button className={!isLogIn ? 'active' : ""} onClick={() => SetLogIn(false)}>SignUp</button>
            </div>
            {isLogIn ? <>
            <div>
                <form className='form' onSubmit={logIn1}>
                <h2>LogIn</h2>
                <input type='text' placeholder='UserName' name='UserName' value={logInData.UserName} onChange={handleLogIn}/>
                <input type='password' placeholder='Password' name='Password' value={logInData.Password} onChange={handleLogIn}/>
                <a href='# '>Forgot Password</a>
                <button>LogIn</button>
                </form>
                <p>Not a Member? <a href='#' onClick={() => SetLogIn(false)}>SignUp Now</a></p>
            </div>
            </> :
             <>
             <div >
                <form onSubmit={addUser} className='form'>
                 <h2>SignUp</h2>
                 <input type='text' placeholder='Enter Name' name='Name' value={createUser.Name} onChange={handleChange}/>
                 <input type='text' placeholder='Enter UserName' name='UserName' value={createUser.UserName} onChange={handleChange}/>
                 <input type='password' placeholder='Enter PassWord' name='Password' value={createUser.Password} onChange={handleChange}/>

                 <button>SignUp</button>
                 </form>
             </div>
            </>}
        </div>
      
     </div>
  )
}

export default AuthForm
