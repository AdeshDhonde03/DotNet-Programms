import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Navbar from './Navbar'
import Table from './Components/Table'
import Counter from './Components/Counter'
import Voting from './Components/Voting'
import EmployeeTable from './Components/EmployeeTable'

function App() {
  const [count, setCount] = useState(0)


  let EmployeeList=[
    {
    "employeeId":1,
    "name":"Akash",
    "email":"akash@gmail.com",
    "salary":1234
  },
  {
    "employeeId":2,
    "name":"Adesh",
    "email":"adesh@gmail.com",
    "salary":1234
  }
];

let StudentList=[
  {
    "RollNo":1,
    "name":"Yogendra",
    "std":"5th"
  },
  {
    "RollNo":2,
    "name":"Gaurav",
    "std":"5th"
  },
  {
    "RollNo":3,
    "name":"sita",
    "std":"5th"
  }
];

  return (
    <>
      {/* <Navbar/>
      <Table list={EmployeeList}/>
      <Counter/>

      <Voting/>

      <Table list={StudentList}/>
       */}

       <EmployeeTable/>
    </>
  )
}

export default App
