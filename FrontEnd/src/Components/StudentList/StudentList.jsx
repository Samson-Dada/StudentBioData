import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import GetStudentList from "../Hooks/StudentHooks";

const StudentList = () => {
  const nav = useNavigate();
  const [student, setStudent] = useState([]);

  useEffect(() => {
    const studentList = async () => {
      const response = await GetStudentList();
      setStudent(response);
    };
    studentList();
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
              <tr key={student.studentId} onClick={() => nav(`/students/${student.studentId}`)}>
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
