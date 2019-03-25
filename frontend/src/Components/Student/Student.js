import React, { Component } from "react";
import "../Student/Student.css";

export class Student extends Component {
  displayName = Student.name;

  render() {
    const timing = ["Done", "To Be Done"];
    const options = timing.map(opt => <option key={opt}>{opt}</option>);
    return (
      <div className="container-fluid" style={{ width: "100%" }}>
        <h5>Welcome,Student!</h5>
        <h6>Details</h6>

        <section id="tabs" className="project-tab">
          <div className="row py-4">
            <div className="col-sm-12">
              <nav>
                <div
                  className="nav nav-tabs nav-fill"
                  id="nav-tab"
                  role="tablist"
                >
                  <div
                    className="link col-sm-4 active"
                    id="assessments-tab"
                    data-toggle="tab"
                    href="#assessments"
                    role="tab"
                    aria-controls="assessments"
                    aria-selected="true"
                  >
                    Assessments
                  </div>
                  <div
                    className="link col-sm-4"
                    id="modules-tab"
                    data-toggle="tab"
                    href="#modules"
                    role="tab"
                    aria-controls="modules"
                    aria-selected="false"
                  >
                    MyModules
                  </div>
                  <div
                    className="link col-sm-4"
                    id="timetable-tab"
                    data-toggle="tab"
                    href="#timetable"
                    role="tab"
                    aria-controls="timetable"
                    aria-selected="false"
                  >
                    Timetable
                  </div>
                </div>
              </nav>
              <div className="tab-content py-4" id="nav-tabContent">
                <div
                  className="tab-pane active"
                  id="assessments"
                  role="tabpanel"
                  aria-labelledby="assessments-tab"
                >
                  <div className="container py-3">
                    <div className="form-group input-group-sm col-sm-4">
                      <select
                        name="timing"
                        className="form-control"
                        defaultValue={""}
                        onChange={this.handleChange}
                      >
                        <option value="" disabled hidden>
                          Done/ToBeDone
                        </option>
                        {options}
                      </select>
                    </div>
                    <table class="table table-sm pt-3">
                      <thead class="thead-dark">
                        <tr>
                          <th scope="col">#</th>
                          <th scope="col">Assessment Name</th>
                          <th scope="col">Module Name</th>
                          <th scope="col">Start Date</th>
                          <th scope="col">Deadline</th>
                          <th scope="col">Grade</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <th scope="row">1</th>
                          <td>Mark</td>
                          <td>Otto</td>
                          <td>@mdo</td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                </div>
                <div
                  className="tab-pane"
                  id="modules"
                  role="tabpanel"
                  aria-labelledby="modules-tab"
                >
                  <table class="table table-sm pt-3">
                    <thead class="thead-dark">
                      <tr>
                        <th scope="col">#</th>
                        <th scope="col">Module Name</th>
                        <th scope="col">Lecturer</th>
                        <th scope="col">Grade</th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr>
                        <th scope="row">1</th>
                        <td>Mark</td>
                        <td>Otto</td>
                        <td>@mdo</td>
                      </tr>
                    </tbody>
                  </table>
                </div>
                <div
                  className="tab-pane"
                  id="timetable"
                  role="tabpanel"
                  aria-labelledby="timetable-tab"
                >
                  timetable
                </div>
              </div>
            </div>
          </div>
        </section>
      </div>
    );
  }
}

export default Student;