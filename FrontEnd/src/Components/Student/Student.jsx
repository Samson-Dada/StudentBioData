import { useEffect } from "react";
import { useState } from "react";
import config from "../../Config";
import image1 from "../../assets/Images/john-deo.jpg";

const Student = () => {
  const [student, setStudent] = useState([]);

  const fetchStudent = async () => {
    const data = await fetch(`${config.baseApiUrl}/students`);
    const response = await data.json();
    console.log(data);
    setStudent(response);
  };

  useEffect(() => {
    fetchStudent();
  }, []);
  return (
    <section className="student__section container-sm">
      {student.map(data => (
        // eslint-disable-next-line react/jsx-key
        <div className="row">
          <div className="col-lg-3">
            <div className="card">
              <div className="card-body profile-card pt-4 d-flex flex-column align-items-center">
                <img src={image1} alt="Profile" className="rounded-circle" />
                <div className="d-flex gap-2 m-1 p-1 bold shadow-sm align-items-center">
                  <p>{data.firstName}</p>
                  <p>{data.lastName}</p>
                </div>
                <p className="">
                  <i className="bi bi-collection shadow p-2 rounded-circle"></i> Class
                </p>
                <p>{data.gender}</p>
                <p>
                  <i className="bi bi-person-fill shadow p-1 rounded-circle"></i> Gender
                </p>
              </div>
            </div>
          </div>
        </div>
      ))}
    </section>
  );
};

export default Student;
