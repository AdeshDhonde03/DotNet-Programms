import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import FamilyTable from './components/FamilyTable'
import EmployeeTable from './components/EmployeeTable'
import EmployeeTable1 from './components/EmployeeTable1'

function App() {
  const [count, setCount] = useState(0)
  let employee=[
    {
      "name":"Adesh",
      "surname":"Dhonde"
    },
    {
      "name":"Akash",
      "surname":"Dhonde"
    },
    {
      "name":"Abhi",
      "surname":"Dhonde"
    }

  ];

  return (
    <>
    {/* <FamilyTable employee={employee}/> */}

    {/* <EmployeeTable/> */}
    <EmployeeTable1/>
    </>
  )
}

export default App
