import React from "react";
import Container from "@mui/material/Container";
import Grid from "@mui/material/Grid";
import Link from "@mui/material/Link";
import TelegramIcon from "@mui/icons-material/Telegram";
import InstagramIcon from "@mui/icons-material/Instagram";
import YouTubeIcon from "@mui/icons-material/YouTube";
export default function Footer() {
  return (
    <footer className="footer">
      <Container sx={{ pt: 3 }}>
        <Grid container className="links" sx={{ mb: 2 }}>
          <Grid item xs={4}>
            <Link sx={{ mr: 1 }} href="#">
              <TelegramIcon sx={{ fontSize: 50 }} />
            </Link>
          </Grid>
          <Grid item xs={4}>
            <Link sx={{ mr: 1 }} href="#">
              <InstagramIcon sx={{ fontSize: 50 }} />
            </Link>{" "}
          </Grid>
          <Grid item xs={4}>
            <Link href="#">
              <YouTubeIcon sx={{ fontSize: 50 }} />
            </Link>
          </Grid>
        </Grid>

        <p>&copy; CoFinder {new Date().getFullYear()}</p>
      </Container>
    </footer>
  );
}
