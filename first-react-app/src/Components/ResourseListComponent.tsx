import ResourseListModel from "../Models/ResourseListModel";
import GetResourceList from "../Http/GetResourseListRequest";
import Card from "@material-ui/core/Card";
import { useState, useEffect } from "react";
import classes from "./Component.module.css";

const ResponseListComponent = (): JSX.Element => {
  const [newRespourseList, setResourseList] = useState<ResourseListModel>();
  useEffect(() => {
    async function init() {
      const result = await GetResourceList();
      setResourseList(result);
    }

    init();
  }, []);

  return (
    <Card className={classes.cardStyle}>
      <h1 className={classes.header}>
        <b>Resourse list</b>
      </h1>
      <div>
        Page: {newRespourseList?.page}
        {newRespourseList?.data &&
          newRespourseList.data.map((x, index) => (
            <div key={index}>
              Name: {x.name}, Color: {x.color}
            </div>
          ))}
      </div>
    </Card>
  );
};

export default ResponseListComponent;
