import photo from "../Images/img.jpg";
import "./ComponentsStyles.css";

const HomePageComponent = (): JSX.Element => {
    return (
        <>
            <div className="container text-center my-5">
                <div className="row">
                    <div className="col-lg-5 col-md-7 col-sm-12 mx-auto">
                        <img
                            src={photo}
                            className="roundedImg"
                            alt="Kud Andrei"
                        />
                        <h1 className="fw-light">Kud Andrei</h1>
                        <p className="lead text-muted">
                            I'm glad to see you here. This page is result of my
                            trys to write code on React.
                        </p>
                        <a
                            href="https://www.linkedin.com/in/andrew-kud-237b101b0/"
                            target="_blank"
                            className="btn btn-primary"
                        >
                            LinkedIn
                        </a>
                    </div>
                </div>
            </div>
        </>
    );
};

export default HomePageComponent;
