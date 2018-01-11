import React, { Component } from "react";
import ReactDOM from 'react-dom';
import { FormControl, FormGroup, ControlLabel, HelpBlock, Checkbox, Radio, Button } from 'react-bootstrap';
var Config = require('Config');

export default class EventInsertForm extends Component {
    get displayName() { return 'Event Form'; }

    constructor(props) {
        super(props);
        this.state = { eventName: '', venue: '' };

        this.options = this.getCategoriesForSelect();

        this.handleEventNameChange = this.handleEventNameChange.bind(this);
        this.addEvent = this.addEvent.bind(this);
    }

    getEventNameValidationState() {
        const length = this.state.eventName.length;
        if (length > 2) return 'success';
        else if (length > 0) return 'warning';
        else if (length == 0) return 'error';
    }

    handleEventNameChange(e) {
        this.setState({ eventName: e.target.value });
    }

    getCategoriesForSelect() {
        fetch(Config.serverUrl + '/api/categories', {
            method: 'GET',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin': '*'
            },
            onSuccess: function(response){
                return response.json();
            }
        });
    }
    
    addEvent() {
        if (this.getEventNameValidationState() === 'success') {

            fetch(Config.serverUrl + '/api/events', {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json',
                    'Access-Control-Allow-Origin': '*'
                },
                body: JSON.stringify({
                    name: this.state.eventName
                })
            });
        }
    }

    render() {
        return (
            <form className="form-group">
                <FormGroup controlId="eventNameInput" validationState={this.getEventNameValidationState()}>
                    <ControlLabel>Insert Event</ControlLabel>
                    <FormControl
                        type="text"
                        value={this.state.eventName}
                        placeholder="Enter event name"
                        onChange={this.handleEventNameChange}
                    />
                    <FormControl.Feedback />
                    <HelpBlock>Validation is based on string length.</HelpBlock>
                </FormGroup>
                <FormGroup controlId="eventCategoryInput" validationState={this.getEventNameValidationState()}>
                    <ControlLabel>Insert Event</ControlLabel>
                    <FormControl.Feedback />
                    <HelpBlock>You must enter a category type.</HelpBlock>
                </FormGroup>
                <Button bsStyle="primary" onClick={this.addEvent}>Insert event</Button>
            </form>);
    }
};