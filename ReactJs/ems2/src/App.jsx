import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import EmployeeTable from './Component/EmployeeTable'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
     <EmployeeTable/>
    </>
  )
}

export default App
