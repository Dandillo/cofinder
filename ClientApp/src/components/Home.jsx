import { Box, Divider } from "@mui/material";
import Button from "@mui/material/Button";
import Container from "@mui/material/Container";
import React, { Component } from "react";

export class Home extends Component {
  static displayName = Home.name;

  render() {
    document.body
      .querySelector(".container")
      .classList.add("section-container");
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
