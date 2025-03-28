import React from 'react'

const FamilyTable = ({employee}) => {
  return (
  
        <table border={1}>
             
         {/* <tr>
                    <th>Name</th>
                    <th>surname</th>
                    
                </tr>
                <tr>
                    <td>{employee.name}</td>
                    <td>{employee.surname}</td>
                    
                    
                </tr>  */}

              <tr>
                {
                    Object.keys(employee[0]).map((key) =>{
                        return(
                            <th>{key}</th>
                        )
                    })
                }
            </tr>

           {
            employee.map((employee) =>{
                    return(
                        <tr>
                            {
                                Object.keys(employee).map((key) =>{
                                    return(
                                        <td>{employee[key]}</td>
                                    )

                                })
                            }
                        </tr>
                    )
                }

            )


           } 
            

        </table>

    
    )
}

export default FamilyTable
