import { Flight } from "./Flight";

export interface Journey{

    Origin: string;
    Destination: string;
    PriceView: number;
    Price: number;
    Flights: Array<Flight>;
}