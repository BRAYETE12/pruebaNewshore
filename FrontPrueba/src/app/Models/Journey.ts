import { Flight } from "./Flight";

export class Journey{

    Origin!: string;
    Destination!: string;
    Price!: number;
    Flights: Array<Flight> = [];
    
    constructor(){}
}