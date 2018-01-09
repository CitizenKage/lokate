import React, { Component } from "react";
import ReactDOM from 'react-dom';

import venueInsertForm from './components/venue-insert-form';
import categoryInsertForm from './components/category-insert-form';
import eventInsertForm from './components/event-insert-form';
import attendeeInsertForm from './components/attendee-insert-form';
import 'react-select/dist/react-select.css';

export default class App extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <eventInsertForm />
                <hr />
                <venueInsertForm />
                <hr />
                <categoryInsertForm />
                <hr />
                <attendeeInsertForm />
                <hr />
            </div>
        );
    }
}

ReactDOM.render(
    <App />,
    document.getElementById('app')
);