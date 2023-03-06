import { Box, Divider } from "@mui/material";
import Button from "@mui/material/Button";
import Container from "@mui/material/Container";
import React, { Component } from "react";

export class Home extends Component {
  componentDidMount() {
    document.body
      .classList.add("section-container");
  }
  componentWillUnmount() {
    document.body
      .classList.remove("section-container");
  }
  static displayName = Home.name;
  render() {
    return (
      <div
        style={{
          display: "flex",
          flexDirection: "column",
          alignItems: "center",
          justifyContent: "center",
          height: "100vh",
        }}
      >
        <h1 style={{ color: "white", textAlign: "center" }}>
          Соберем команду единомышленников
        </h1>
        <Divider />
        <Button variant="contained" size="large" sx={{ mt: 2 }}>
          Присоединяйся к нам!
        </Button>
      </div>
    );
  }
}
