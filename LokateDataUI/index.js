import React, { Component } from "react";
import ReactDOM from 'react-dom';
import EventInsertForm from './components/event-insert-form';
import VenueInsertForm from './components/venue-insert-form';
import CategoryInsertForm from './components/category-insert-form';
import AttendeeInsertForm from './components/attendee-insert-form';

export default class App extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <EventInsertForm />
                <hr />
                <VenueInsertForm />
                <hr />
                <CategoryInsertForm />
                <hr />
                <AttendeeInsertForm />
                <hr />
            </div>
        );
    }
}

ReactDOM.render(
    <App />,
    document.getElementById('app')
);