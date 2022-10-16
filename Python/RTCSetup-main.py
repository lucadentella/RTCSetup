#!/usr/bin/env python
"""
this script is used to set RTC date time, see https://github.com/def-fun/RTCSetup
"""
import serial  # pip install pyserial
import serial.tools.list_ports
import datetime


def main():
    # show available serial port
    port_list = list(serial.tools.list_ports.comports())
    index = 0
    print('-' * 42)
    for port in port_list:
        print(f'{index}:\t{port.device}')
        print(f'\t\tdescription: {port.description}')
        print(f'\t\thardware-id: {port.hwid}')
        print(f'\t\tserial-number: {port.serial_number}')
        print(f'\t\tmanufacturer: {port.manufacturer}')
        # print(port.__dict__)
        index += 1
    print('-' * 42)
    print('input integer to choose serial port')
    i = input('your choice: ')
    selected_port = port_list[index - 1]

    selected_serial = serial.Serial(selected_port.device, 57600, timeout=1)
    dt = datetime.datetime.now()
    print('datetime now:', dt)
    payload = f'!T{dt.day}{dt.month}{dt.year}{dt.hour}{dt.minute}{dt.second}\n'.encode()
    # or you can set other datetime payload, for example: payload = b'!T16102022124653\n'
    # print(payload)
    selected_serial.write(payload)
    resp = selected_serial.readline()
    print('resp:', resp)

    selected_serial.write('?T\n'.encode())
    resp = selected_serial.readline()
    print('resp:', resp)


if __name__ == '__main__':
    main()
