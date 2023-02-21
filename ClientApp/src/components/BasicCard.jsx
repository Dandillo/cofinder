import * as React from "react";
import Box from "@mui/material/Box";
import Card from "@mui/material/Card";
import CardActions from "@mui/material/CardActions";
import CardContent from "@mui/material/CardContent";
import Button from "@mui/material/Button";
import Typography from "@mui/material/Typography";
import { Avatar, Grid } from "@mui/material";

const bull = (
  <Box
    component="span"
    sx={{ display: "inline-block", mx: "2px", transform: "scale(0.8)" }}
  >
    #
  </Box>
);

export default function BasicCard(props) {
  return (
    <Card sx={{ minWidth: 275, mt: 2 }}>
      <CardContent sx={{ display: "flex" }}>
        <Grid
          container
          justifyContent="center"
          alignItems="center"
          justifyItems="center"
          columnSpacing={1}
        >
          <Grid item xs={2}>
            <Avatar
              alt="Remy Sharp"
              src="/static/images/avatar/1.jpg"
              sx={{ width: 70, height: 70 }}
            ></Avatar>
          </Grid>
          <Grid item xs={8}>
            <Box>
              <Typography variant="h2" component="div">
                Название проекта
              </Typography>
              <Typography variant="h5" component="div">
                {bull}IT{bull}Маркетинг{bull}Общество
              </Typography>
              <Typography sx={{ mb: 1.5 }} color="text.secondary">
                Сфера проекта: Industry
              </Typography>
              <Typography sx={{ mb: 1.5 }} color="text.secondary">
                О проекте кратко: Lorem ipsum, dolor sit amet consectetur
                adipisicing elit. Beatae laboriosam adipisci reiciendis quod
                iste iure labore, enim porro neque culpa quis consequuntur earum
                odio hic at molestiae minus sed praesentium?
              </Typography>
              <Typography variant="body2">Кто требуется</Typography>
            </Box>
          </Grid>
        </Grid>
      </CardContent>
      <CardActions>
        <Button size="large">Подробнее</Button>
      </CardActions>
    </Card>
  );
}
