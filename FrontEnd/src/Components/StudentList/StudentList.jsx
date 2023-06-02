import { useEffect, useState } from "react";
import axios from "axios";
import fetchStudents from "../Hooks/StudentHooks";

const StudentList = () => {
  const [student, setStudent] = useState([]);

  useEffect(() => {
    const fetchStudentData = async () => {
      const response = await fetchStudents();
      setStudent(response);
    };
    fetchStudentData();
  }, []);
  return (
    <section className="student__section container-sm">
      <table className="table table-hover">
        <thead>
          <tr>
            <th className="col">#</th>
            <th className="col">FirstName</th>
            <th className="col">LastName</th>
            <th className="col">Gender</th>
            <th className="col">Age</th>
          </tr>
        </thead>
        <tbody>
          {student &&
            student.map(student => (
              <tr key={student.studentId}>
                <td>{student.studentId}</td>
                <td>{student.firstName}</td>
                <td>{student.lastName}</td>
                <td>{student.gender}</td>
                <td>{student.dateOfBirth}</td>
              </tr>
            ))}
        </tbody>
      </table>
    </section>
  );
};

export default StudentList;
