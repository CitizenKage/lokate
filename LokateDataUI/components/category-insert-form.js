import React, { Component } from "react";
import ReactDOM from 'react-dom';
import { FormControl, FormGroup, ControlLabel, HelpBlock, Checkbox, Radio, Button } from 'react-bootstrap';
var Config = require('Config');

export default class CategoryInsertForm extends Component {
    get displayName() { return 'Category Form'; }

    constructor(props) {
        super(props);
        this.state = { CategoryName: '' };

        this.handleCategoryNameChange = this.handleCategoryNameChange.bind(this);
        this.addCategory = this.addCategory.bind(this);
    }

    getCategoryNameValidationState() {
        const length = this.state.CategoryName.length;
        if (length > 2) return 'success';
        else if (length > 0) return 'warning';
        else if (length == 0) return 'error';
    }

    handleCategoryNameChange(e) {
        this.setState({ CategoryName: e.target.value });
    }

    addCategory() {
        if (this.getCategoryNameValidationState() === 'success') {

            fetch(Config.serverUrl + '/api/categories', {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json',
                    'Access-Control-Allow-Origin': '*'
                },
                body: JSON.stringify({
                    name: this.state.CategoryName
                })
            })
        }
    }

    render() {
        return (
            <form class="form-group">
                <FormGroup controlId="CategoryNameInput" validationState={this.getCategoryNameValidationState()}>
                    <ControlLabel>Insert Category</ControlLabel>
                    <FormControl
                        type="text"
                        value={this.state.CategoryName}
                        placeholder="Enter Category name"
                        onChange={this.handleCategoryNameChange}
                    />
                    <FormControl.Feedback />
                    <HelpBlock>Validation is based on string length.</HelpBlock>
                </FormGroup>
                <Button bsStyle="primary" onClick={this.addCategory}>Insert Category</Button>
            </form>);
    }
};