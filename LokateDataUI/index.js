import React, { Component } from "react";
import ReactDOM from 'react-dom';
import {FormControl, FormGroup, ControlLabel, HelpBlock, Checkbox, Radio, Button} from 'react-bootstrap';

export default class NameForm extends Component {

    get displayName() { return 'Name Form'; }

    constructor(props) {
        super(props);
        this.state = { clubName: '', clubLatitude: '', clubLongitude: '', imageUrl: '' };

        this.handleClubNameChange = this.handleClubNameChange.bind(this);
        this.handleClubLatitudeChange = this.handleClubLatitudeChange.bind(this);
        this.handleClubLongitudeChange = this.handleClubLongitudeChange.bind(this);
        this.handleImageUrlChange = this.handleImageUrlChange.bind(this);
        //this.handleSubmit = this.handleSubmit.bind(this);
    }

    getClubNameValidationState() {
        const length = this.state.clubName.length;
        if (length > 2) return 'success';
        else if (length > 0) return 'warning';
        else if (length == 0) return 'error';
    }

    getLatitudeValidationState() {
        const length = this.state.clubLatitude.length;
        if (length > 2) return 'success';
        else if (length > 0) return 'warning';
        else if (length == 0) return 'error';
    }

    getLongitudeValidationState() {
        const length = this.state.clubLongitude.length;
        if (length > 2) return 'success';
        else if (length > 0) return 'warning';
        else if (length == 0) return 'error';
    }

    getImageUrlValidationState() {
        const length = this.state.imageUrl.length;
        if (length > 2) return 'success';
        else if (length > 0) return 'warning';
        else if (length == 0) return 'error';
    }

    handleClubNameChange(e) {
        this.setState({ clubName: e.target.value });
    }

    handleClubLatitudeChange(e) {
        this.setState({ clubLatitude: e.target.value });
    }

    handleClubLongitudeChange(e) {
        this.setState({ clubLongitude: e.target.value });
    }

    handleImageUrlChange(e) {
        this.setState({ imageUrl: e.target.value });
    }

    render() {
        return (
            <form>
                <FormGroup controlId="clubNameInput" validationState={this.getClubNameValidationState()}>
                    <ControlLabel>Insert Club</ControlLabel>
                    <FormControl
                        type="text"
                        value={this.state.clubName}
                        placeholder="Enter club name"
                        onChange={this.handleClubNameChange}
                    />
                    <FormControl.Feedback />
                    <HelpBlock>Validation is based on string length.</HelpBlock>
                </FormGroup>
                <FormGroup controlId="latitudeInput" validationState={this.getLatitudeValidationState()}>
                    <ControlLabel>Insert Latitude</ControlLabel>
                    <FormControl
                        type="text"
                        value={this.state.clubLatitude}
                        placeholder="Enter latitude"
                        onChange={this.handleClubLatitudeChange}
                    />
                    <FormControl.Feedback />
                    <HelpBlock>Validation is based on string length.</HelpBlock>
                </FormGroup>
                <FormGroup controlId="longitudeInput" validationState={this.getLongitudeValidationState()}>
                    <ControlLabel>Insert Longitude</ControlLabel>
                    <FormControl
                        type="text"
                        value={this.state.clubLongitude}
                        placeholder="Enter longitude"
                        onChange={this.handleClubLongitudeChange}
                    />
                    <FormControl.Feedback />
                    <HelpBlock>Validation is based on string length.</HelpBlock>
                </FormGroup>
                <FormGroup controlId="imageUrlInput" validationState={this.getImageUrlValidationState()}>
                    <ControlLabel>Insert Image URL</ControlLabel>
                    <FormControl
                        type="text"
                        value={this.state.imageUrl}
                        placeholder="Enter image URL"
                        onChange={this.handleImageUrlChange}
                    />
                    <FormControl.Feedback />
                    <HelpBlock>Validation is based on string length.</HelpBlock>
                </FormGroup>
            </form>);
    }
}

ReactDOM.render(
    <NameForm />,
    document.getElementById('app')
);