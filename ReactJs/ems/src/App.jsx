import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Layout from './components/Layout'
import Home from './components/Home'
import EmployeeTable from './components/EmployeeTable'
import { createBrowserRouter, RouterProvider } from 'react-router-dom'
import Counter from './components/Counter'
import StopWatch from './components/StopWatch'

function App() {
  const [count, setCount] = useState(0)

  let router=createBrowserRouter([
    {
      "path":"/",
      "element":<Layout/>,
      "children":[
        {
          "path":"",
          "element":<Home/>
        },
        {
          "path":"employees",
          "element":<EmployeeTable/> 
        },
        {
          "path":"counter",
          "element":<Counter/>
        },
        {
          "path":"stopwatch",
          "element":<StopWatch/>
        }
       
      ]
    }
  ])

  return (
    <>
    
    <RouterProvider router={router}>

    </RouterProvider>
    </>
  
    
  )
}

export default App
