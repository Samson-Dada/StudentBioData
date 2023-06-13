// import { useState } from "react";
import Student from "../Components/Student/Student";
import StudentList from "../Components/StudentList/StudentList";
import { BrowserRouter, Route, Routes } from "react-router-dom";
55;
import "./App.css";
import StudentDetail from "../Components/StudentDetail/StudentDetail";
function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<StudentList />} />
        <Route path="/students/:id" element={<StudentDetail />} />
      </Routes>
    </BrowserRouter>
  );
}
export default App;
