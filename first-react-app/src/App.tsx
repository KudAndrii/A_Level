import logo from "./logo.svg";
import "./App.css";
import UserComponent from "./Components/UserComponent";
import ResponseComponent from "./Components/ResourseComponent";

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
        <ResponseComponent></ResponseComponent>
      </ul>
    </div>
  );
}

export default App;
