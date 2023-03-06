import "bootstrap/dist/css/bootstrap.css";

import React, { Component } from "react";
import { Link, Outlet } from "react-router-dom";
import  Container  from "@mui/material/Container";
import Footer from "./Footer";
import Header from "./Header";

const Layout = () => {
  return (
    <div className="App">
      <Header />
      <Container>
        <Outlet />
      </Container>
      <Footer />
    </div>
  );
};
export { Layout };
