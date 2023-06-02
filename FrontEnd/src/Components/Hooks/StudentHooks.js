import axios from "axios";
import config from "../../Config";
export const fetchStudents = async () => {
  const response = await fetch(`${config.baseApiUrl}/students`);
  const data = await response.json();
  console.log(data);
  return data;
};

export const fetchStudentList = axios.get(`${config.baseApiUrl}/students`);
