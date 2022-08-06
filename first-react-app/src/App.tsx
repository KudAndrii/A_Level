import React from "react";
import logo from "./logo.svg";
import "./App.css";
import UserComponent from "./Components/UserComponent";
import GetUser from "./Http/GetUserRequest";
import UserModel from "./Models/UserModel";

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <div>
          <img src={logo} className="App-logo" alt="logo" />
        </div>
        <div>
          Edit <code>src/App.tsx</code> and save to reload.
        </div>
      </header>
      <ul>
        <UserComponent></UserComponent>
      </ul>
    </div>
  );
}

export default App;
