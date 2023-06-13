import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { GetStudentById } from "../Hooks/StudentHooks";
import style from "./StudentDetial.module.css";
import image1 from "../../assets/Images/john-deo.jpg";

const StudentDetail = () => {
  const { id } = useParams();
  const [student, setStudent] = useState(null);

  if (!id) throw new Error("Student ID not found");
  const studentId = parseInt(id);

  useEffect(() => {
    const fetchStudentDetails = async () => {
      const response = await GetStudentById(studentId);
      setStudent(response);
    };

    fetchStudentDetails();
  }, [studentId]);

  if (!student) {
    return <p>Loading...</p>;
  }
  /* NOT WORKING CORRECTLY */
  //   if (student.id !== studentId) {
  //     return <p>No Student found</p>;
  //   }

  return (
    <section className="container m-3">
      <div className="card p-4 w-50 border-bottom border-secondary border-5">
        <div className="row align-items-center">
          <div className="col-md-6">
            <img src={image1} className=" rounded-circle" alt=".../" />
          </div>
          <div className="col-md-6">
            <div className="card-body">
              <p className="card-text">
                This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.
              </p>
              <p>Detail working</p>
              <p>Student ID: {student.studentId}</p>
              <p>First Name: {student.firstName}</p>
              <p>Last Name: {student.lastName}</p>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default StudentDetail;
