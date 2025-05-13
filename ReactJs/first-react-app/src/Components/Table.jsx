


const Table= ({list}) =>{

    return(
        <table>
            {/* simple Method */}
            {/* <tr>
                <th>EmployeeId</th>
                <th>Name</th>
                <th>Email</th>
                <th>Salary</th>
            </tr>
            <tr>
                <td>{employee.employeeId}</td>
                <td>{employee.name}</td>
                <td>{employee.email}</td>
                <td>{employee.salary}</td>
            </tr> */}


            {/* make Table Dynamically through the list */}

            <tr>
                {
                    Object.keys(list[0]).map((key) =>{
                        return(
                            <th>{key}</th>
                        )
                    })
                }
            </tr>

           {
            list.map((employee) =>{
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
export default Table