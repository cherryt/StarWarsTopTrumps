import React, { Component } from 'react';
import CardDeck from 'react-bootstrap/CardDeck'
import { StarWarsCard } from './StarWarsCard';

export class CardGame extends Component {

    constructor(props) {
        super(props);
        this.state = {
            starshipDetails: {}, loading: true };
    }

    componentDidMount() {
        this.setFirstCard();
        this.setComputerCard();
    }

    render() {
        //TODO: 
        // - create and add new component which contains score, StarWarsCard component
        // - create function to determine win/lose, and function for incrementing score
        // - create pop up modal component for win/lose msg
        // - make categories clickable, onclick action should call getNextCard()
        // - add styling
    return (
        <CardDeck>
            <div>
                YOU
                <StarWarsCard details={this.state.starshipDetails}></StarWarsCard>
            </div>
            <div>
                COMPUTER
                <StarWarsCard details={this.state.computerStarshipDetails}></StarWarsCard>
            </div>

        </CardDeck>
    );
    }
    async setFirstCard() {
        const response = await fetch('/StarshipCard/FirstCard/');
        const data = await response.json();
        this.setState({ starshipDetails: data, loading: false });
    }

    async setComputerCard() {
        this.setState({ computerStarshipDetails: await this.getNextCard(), loading: false });
    }

    async getNextCard() {
        const response = await fetch('StarshipCard/NextCard');
       return await response.json();
    }
}
