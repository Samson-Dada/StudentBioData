import axios from "axios";
import config from "../../Config";

const GetStudentList = async () => {
  try {
    return axios.get(`${config.baseApiUrl}/students`).then(response => {
      return response.data;
    });
  } catch (error) {
    console.error("Error fetch student data from API", error);
    return [];
  }
};

export const GetStudentById = async id => {
  try {
    return axios.get(`${config.baseApiUrl}/students/${id}`).then(response => {
      return response.data;
    });
  } catch (error) {
    console.error(`Error fetch student data from API with {id}`, error);
  }
  return id;
};

// export { fetchStudentById };
export default GetStudentList;
