import React, { Component } from 'react';
import { CardGame } from './CardGame'

export class Home extends Component {
  static displayName = Home.name;

  render () {
      return (
          <CardGame></CardGame>
    );
  }
}
