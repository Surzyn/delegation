import React from "react";
import { Link } from "react-router-dom";
import { Logo } from "../logo";

export const Header = () => {
  return (
    <header>
      <Logo />
      <nav>
        <ul>
          <li>
            <Link to="/">Home</Link>
          </li>
          <li>
            <Link to="/list">All delegations</Link>
          </li>
          <li>
            <Link to="/form">Form</Link>
          </li>
        </ul>
      </nav>
    </header>
  );
};
