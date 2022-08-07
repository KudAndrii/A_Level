import ResourseModel from "../Models/ResourceModel";
import GetResource from "../Http/GetResourceRequest";
import Card from "@material-ui/core/Card";
import { useState, useEffect } from "react";
import classes from "./Component.module.css";
import { Button, Form } from "react-bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";
import ChildResourseComponent from "./ChildResourseComponent";
import { Input } from "@material-ui/core";

type Input = {
  resourseId: { value: string };
};

let input: string;

const ResponseComponent = (): JSX.Element => {
  return (
    <Card className={classes.cardStyle}>
      <div className={classes.flexable}>
        <div className={classes.flexcontainer}>
          <Form
            onSubmit={(e) => {
              e.preventDefault();
              debugger;
              const target = e.target as typeof e.target & Input;
              input = target.resourseId.value;
            }}
          >
            <Form.Group controlId="resourseId">
              <Form.Label>
                <i>Enter resourse id</i>
              </Form.Label>
              <Form.Control></Form.Control>
            </Form.Group>
            <Button
              variant="btn btn-primary active"
              type="submit"
              onClick={(ev: React.MouseEvent<HTMLButtonElement>) => {
                console.log("Inside button handler");

                setCount((prevValue) => prevValue + 1);
                setCounts((prevValueArray) => {
                  console.log("Inside setCounts: prevValueArray.");

                  return [...prevValueArray, count]; // copy is needed
                });
              }}
            >
              find
            </Button>
          </Form>
        </div>
        <div className={classes.flexcontainer}>
          <h1 className={classes.header}>
            <b>Resourse</b>
          </h1>
          <ChildResourseComponent resourseId={input}></ChildResourseComponent>
        </div>
      </div>
    </Card>
  );
};

export default ResponseComponent;
