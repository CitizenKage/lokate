import React, { Component } from "react";
import ReactDOM from 'react-dom';
import { FormControl, FormGroup, ControlLabel, HelpBlock, Checkbox, Radio, Button } from 'react-bootstrap';
var Config = require('Config');

export default class AttendeeInsertForm extends Component {
    get displayName() { return 'Attendee Form'; }

    constructor(props) {
        super(props);
        this.state = { AttendeeName: '' };

        this.handleAttendeeNameChange = this.handleAttendeeNameChange.bind(this);
        this.addAttendee = this.addAttendee.bind(this);
    }

    getAttendeeNameValidationState() {
        const length = this.state.AttendeeName.length;
        if (length > 2) return 'success';
        else if (length > 0) return 'warning';
        else if (length == 0) return 'error';
    }

    handleAttendeeNameChange(e) {
        this.setState({ AttendeeName: e.target.value });
    }

    addAttendee() {
        if (this.getUserNameValidationState() === 'success') {

            fetch(Config.serverUrl + '/api/users', {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json',
                    'Access-Control-Allow-Origin': '*'
                },
                body: JSON.stringify({
                    name: this.state.AttendeeName
                })
            })
        }
    }

    render() {
        return (
            <form>
                <FormGroup controlId="AttendeeNameInput" validationState={this.getAttendeeNameValidationState()}>
                    <ControlLabel>Insert Attendee Name</ControlLabel>
                    <FormControl
                        type="text"
                        value={this.state.AttendeeName}
                        placeholder="Enter Attendee name"
                        onChange={this.handleAttendeeNameChange}
                    />
                    <FormControl.Feedback />
                    <HelpBlock>Validation is based on string length.</HelpBlock>
                </FormGroup>
                <Button bsStyle="primary" onClick={this.addAttendee}>Insert Attendee</Button>
            </form>);
    }
};