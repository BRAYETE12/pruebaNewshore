import { Transport } from "./Transport";

export class Flight{
    Origin!: string;
    Destination!: string;
    Price!: number;
    Transport!: Transport;
}