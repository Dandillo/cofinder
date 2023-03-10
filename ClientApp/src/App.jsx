import React, { Component } from "react";
import { Route, Routes } from "react-router-dom";
import { Layout } from "./components/Layout";
import { Home } from "./components/Home";

import "./custom.css";
import Projects from "./components/Projects";
import Cvs from "./components/Cvs";
import SignUp from "./components/SignUpForm";

function App() {
  return (
    <>
      
        <Routes>
          <Route path="/" element={<Layout />}>
            <Route index element={<Home />} />
            <Route path="cvs" element={<Cvs />} />
            <Route path="projects" element={<Projects />} />
            <Route path="sign-up" element={<SignUp />} />
          </Route>
        
        </Routes>
 
    </>
  );
}
export default App