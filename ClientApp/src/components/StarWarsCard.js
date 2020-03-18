import React, { Component } from 'react';
import Card from 'react-bootstrap/Card'
import ListGroup from 'react-bootstrap/ListGroup'                                                            

export class StarWarsCard extends Component {

    render() {
        const { details } = this.props;
        if (!details) return "Missing card details.";
        return (
            <Card>
                <Card.Header>{details.name}</Card.Header>
                <ListGroup>
                    <ListGroup.Item action id="speed">
                        Speed: {details.maxSpeed}
                    </ListGroup.Item>
                    <ListGroup.Item action id="cost">
                        Cost In Credits: {details.costInCredits}
                    </ListGroup.Item>
                    <ListGroup.Item action id="passengers">
                        Passengers: {details.numberOfPassengers}
                    </ListGroup.Item>
                    <ListGroup.Item action id="films">
                        Number of Films: {details.numberOfFilms}
                    </ListGroup.Item>
                </ListGroup>
            </Card>
        );
    }
}
