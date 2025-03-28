import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Company from '../Components/Company'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <Company/>
    </>
  )
}

export default App
